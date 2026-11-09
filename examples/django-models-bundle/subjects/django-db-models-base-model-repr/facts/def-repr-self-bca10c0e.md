# Fact bca10c0e

Store id: e2f93d81-6b0a-450c-b18d-d337a5593f3d

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:48.5265080+00:00`

## Data

```json
{
  "end_line": 633,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 632,
  "symbol": "Model.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":632,"selector":"L632-L633","symbol":"Model.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 633,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 632,
    "symbol": "Model.__repr__"
  },
  "id": "e2f93d81-6b0a-450c-b18d-d337a5593f3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5265080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 632,
        "selector": "L632-L633",
        "symbol": "Model.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "a0731119-1456-47e3-96e5-a94e344833e6",
  "subject_name": "django/db/models/base::Model.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
