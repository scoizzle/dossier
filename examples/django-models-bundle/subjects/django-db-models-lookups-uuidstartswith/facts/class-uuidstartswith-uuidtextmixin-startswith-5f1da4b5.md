# Fact 5f1da4b5

Store id: f494fbe0-0223-4c76-8550-3bd45b73ee64

## Text

```text
class UUIDStartsWith(UUIDTextMixin, StartsWith)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:UUIDField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.1148070+00:00`

## Data

```json
{
  "end_line": 817,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 815,
  "symbol": "UUIDStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":815,"selector":"L815-L817","symbol":"UUIDStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 817,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 815,
    "symbol": "UUIDStartsWith"
  },
  "id": "f494fbe0-0223-4c76-8550-3bd45b73ee64",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1148070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 815,
        "selector": "L815-L817",
        "symbol": "UUIDStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a5262afc-6a23-4111-bb52-4cd3c61dbd5b",
  "subject_name": "django/db/models/lookups::UUIDStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDStartsWith(UUIDTextMixin, StartsWith)"
}
```
