# Fact 53cf57b0

Store id: 0436e4e5-00dd-46f4-8502-fd2ec054bdca

## Text

```text
async def asave( self, *, force_insert=False, force_update=False, using=None, update_fields=None, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3385430+00:00`

## Data

```json
{
  "end_line": 926,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 913,
  "symbol": "Model.asave"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":913,"selector":"L913-L926","symbol":"Model.asave"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.asave](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 926,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 913,
    "symbol": "Model.asave"
  },
  "id": "0436e4e5-00dd-46f4-8502-fd2ec054bdca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3385430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 913,
        "selector": "L913-L926",
        "symbol": "Model.asave"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "eb46765b-4f42-49fe-afb5-39580ac9b3f5",
  "subject_name": "django/db/models/base::Model.asave",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def asave( self, *, force_insert=False, force_update=False, using=None, update_fields=None, )"
}
```
