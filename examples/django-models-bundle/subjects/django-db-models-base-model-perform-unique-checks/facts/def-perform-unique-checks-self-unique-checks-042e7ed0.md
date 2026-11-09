# Fact 042e7ed0

Store id: 36db4cbc-334d-486d-a8c8-78c102e5d340

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
- posted_at: `2026-11-09T23:44:48.5421120+00:00`

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
  "id": "36db4cbc-334d-486d-a8c8-78c102e5d340",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5421120+00:00"
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
  "subject_id": "5ac27d16-4c0c-4bea-8721-89c9d6947302",
  "subject_name": "django/db/models/base::Model._perform_unique_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _perform_unique_checks(self, unique_checks)"
}
```
