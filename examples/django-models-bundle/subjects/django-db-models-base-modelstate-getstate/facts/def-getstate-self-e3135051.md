# Fact e3135051

Store id: 962d4d52-2084-4904-a6d9-241e2da4020f

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T22:39:40.3301760+00:00`

## Data

```json
{
  "end_line": 495,
  "entity_kind": "method",
  "parent": "ModelState",
  "start_line": 491,
  "symbol": "ModelState.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":491,"selector":"L491-L495","symbol":"ModelState.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelState.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 495,
    "entity_kind": "method",
    "parent": "ModelState",
    "start_line": 491,
    "symbol": "ModelState.__getstate__"
  },
  "id": "962d4d52-2084-4904-a6d9-241e2da4020f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3301760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 491,
        "selector": "L491-L495",
        "symbol": "ModelState.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7aeee332-137f-4a4d-93cf-e1e996253a8c",
  "subject_name": "django/db/models/base::ModelState.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
