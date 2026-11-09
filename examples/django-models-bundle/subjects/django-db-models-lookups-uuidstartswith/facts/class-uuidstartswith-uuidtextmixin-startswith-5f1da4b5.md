# Fact 5f1da4b5

Store id: 83c69ed1-fde9-4e9c-87c3-3bbd3cf55695

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
- posted_at: `2026-11-09T23:32:03.4837060+00:00`

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
  "id": "83c69ed1-fde9-4e9c-87c3-3bbd3cf55695",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4837060+00:00"
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
  "subject_id": "f105efad-c6b1-4376-98bb-dd3c5f9a1a8f",
  "subject_name": "django/db/models/lookups::UUIDStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDStartsWith(UUIDTextMixin, StartsWith)"
}
```
