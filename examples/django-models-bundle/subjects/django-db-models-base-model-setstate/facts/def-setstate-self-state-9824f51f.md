# Fact 9824f51f

Store id: e27eeea1-1dc4-4119-9196-d5ef62c9c572

## Text

```text
def __setstate__(self, state)
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
- posted_at: `2026-11-09T23:31:53.7351550+00:00`

## Data

```json
{
  "end_line": 696,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 676,
  "symbol": "Model.__setstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":676,"selector":"L676-L696","symbol":"Model.__setstate__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__setstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 696,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 676,
    "symbol": "Model.__setstate__"
  },
  "id": "e27eeea1-1dc4-4119-9196-d5ef62c9c572",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7351550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 676,
        "selector": "L676-L696",
        "symbol": "Model.__setstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "ee0c9924-dba2-43f2-a2a1-716440e1b1a3",
  "subject_name": "django/db/models/base::Model.__setstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __setstate__(self, state)"
}
```
