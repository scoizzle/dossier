# Fact e2d8495e

Store id: ddb6a85d-f231-4518-9ec4-e94ea067df4c

## Text

```text
class IEndsWith(EndsWith)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.0339250+00:00`

## Data

```json
{
  "end_line": 654,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 652,
  "symbol": "IEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":652,"selector":"L652-L654","symbol":"IEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 654,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 652,
    "symbol": "IEndsWith"
  },
  "id": "ddb6a85d-f231-4518-9ec4-e94ea067df4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0339250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 652,
        "selector": "L652-L654",
        "symbol": "IEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6561e476-d7c7-419f-a571-16323bf98c08",
  "subject_name": "django/db/models/lookups::IEndsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IEndsWith(EndsWith)"
}
```
