# Fact 84c7ed91

Store id: a4362562-dde8-498e-86ad-6d79b9364719

## Text

```text
class UUIDEndsWith(UUIDTextMixin, EndsWith)
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
- posted_at: `2026-11-09T23:32:03.4941000+00:00`

## Data

```json
{
  "end_line": 827,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 825,
  "symbol": "UUIDEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":825,"selector":"L825-L827","symbol":"UUIDEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 827,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 825,
    "symbol": "UUIDEndsWith"
  },
  "id": "a4362562-dde8-498e-86ad-6d79b9364719",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4941000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 825,
        "selector": "L825-L827",
        "symbol": "UUIDEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b487eb1d-1383-48f1-85a5-5e9465ebad46",
  "subject_name": "django/db/models/lookups::UUIDEndsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDEndsWith(UUIDTextMixin, EndsWith)"
}
```
