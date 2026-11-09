# Fact 81e4cc79

Store id: 68ff3ba1-2eb0-4c0e-ab8f-24ec868d1dae

## Text

```text
def delete(self, using=None, keep_parents=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7489970+00:00`

## Data

```json
{
  "end_line": 1333,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1324,
  "symbol": "Model.delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1324,"selector":"L1324-L1333","symbol":"Model.delete"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1333,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1324,
    "symbol": "Model.delete"
  },
  "id": "68ff3ba1-2eb0-4c0e-ab8f-24ec868d1dae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7489970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1324,
        "selector": "L1324-L1333",
        "symbol": "Model.delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "251f7535-a3d3-4eec-85ff-362161068a5e",
  "subject_name": "django/db/models/base::Model.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, using=None, keep_parents=False)"
}
```
