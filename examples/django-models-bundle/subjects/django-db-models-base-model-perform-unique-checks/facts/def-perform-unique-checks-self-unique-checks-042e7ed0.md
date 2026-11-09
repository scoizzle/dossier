# Fact 042e7ed0

Store id: 70134561-a9c2-49b3-bc96-389d7e3ddff7

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
- posted_at: `2026-11-09T23:31:53.7557490+00:00`

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
  "id": "70134561-a9c2-49b3-bc96-389d7e3ddff7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7557490+00:00"
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
  "subject_id": "d8deb5d1-abf8-4a27-9110-b2ec717d6969",
  "subject_name": "django/db/models/base::Model._perform_unique_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _perform_unique_checks(self, unique_checks)"
}
```
