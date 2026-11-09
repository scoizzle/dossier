# Fact 79d4cbf7

Store id: d3ec0fed-2fa4-45f7-9032-743fa6944cee

## Text

```text
async def adelete(self, using=None, keep_parents=False)
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
- posted_at: `2026-11-09T22:39:40.3444360+00:00`

## Data

```json
{
  "end_line": 1341,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1337,
  "symbol": "Model.adelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1337,"selector":"L1337-L1341","symbol":"Model.adelete"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.adelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1341,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1337,
    "symbol": "Model.adelete"
  },
  "id": "d3ec0fed-2fa4-45f7-9032-743fa6944cee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3444360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1337,
        "selector": "L1337-L1341",
        "symbol": "Model.adelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "fa4c21ff-12c8-4222-96c5-b6701ad98df3",
  "subject_name": "django/db/models/base::Model.adelete",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def adelete(self, using=None, keep_parents=False)"
}
```
