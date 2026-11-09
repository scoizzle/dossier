# Fact 53cf57b0

Store id: d5bab3cb-b48d-4ac7-af6c-e189af5f79f4

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
- posted_at: `2026-11-09T23:31:53.7405690+00:00`

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
  "id": "d5bab3cb-b48d-4ac7-af6c-e189af5f79f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7405690+00:00"
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
  "subject_id": "e788437e-5b64-4903-ab2b-8b47c0887ec3",
  "subject_name": "django/db/models/base::Model.asave",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def asave( self, *, force_insert=False, force_update=False, using=None, update_fields=None, )"
}
```
