# Fact e3135051

Store id: fc1a67e3-0ce6-4d94-84b8-03fd5b075828

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
- posted_at: `2026-11-09T23:31:53.7304840+00:00`

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
  "id": "fc1a67e3-0ce6-4d94-84b8-03fd5b075828",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7304840+00:00"
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
  "subject_id": "3bdc4e43-f566-4f5c-a406-81b0036339d1",
  "subject_name": "django/db/models/base::ModelState.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
