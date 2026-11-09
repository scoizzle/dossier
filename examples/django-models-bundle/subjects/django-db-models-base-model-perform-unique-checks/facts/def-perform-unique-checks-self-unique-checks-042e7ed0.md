# Fact 042e7ed0

Store id: 887176df-7e00-4baa-a960-720a336ccdb0

## Text

```text
def _perform_unique_checks(self, unique_checks)
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
- posted_at: `2026-11-09T22:39:40.3492940+00:00`

## Data

```json
{
  "end_line": 1591,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1544,
  "symbol": "Model._perform_unique_checks"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1544,"selector":"L1544-L1591","symbol":"Model._perform_unique_checks"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._perform_unique_checks](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1591,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1544,
    "symbol": "Model._perform_unique_checks"
  },
  "id": "887176df-7e00-4baa-a960-720a336ccdb0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3492940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1544,
        "selector": "L1544-L1591",
        "symbol": "Model._perform_unique_checks"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "763dfa46-05b1-47cd-a0e6-508e9a799f93",
  "subject_name": "django/db/models/base::Model._perform_unique_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _perform_unique_checks(self, unique_checks)"
}
```
