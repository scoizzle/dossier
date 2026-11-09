# Fact 79e7f005

Store id: 46b82832-f92c-4a2e-a265-50177b6169a0

## Text

```text
def _perform_date_checks(self, date_checks)
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
- posted_at: `2026-11-09T22:39:40.3497570+00:00`

## Data

```json
{
  "end_line": 1622,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1593,
  "symbol": "Model._perform_date_checks"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1593,"selector":"L1593-L1622","symbol":"Model._perform_date_checks"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._perform_date_checks](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1622,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1593,
    "symbol": "Model._perform_date_checks"
  },
  "id": "46b82832-f92c-4a2e-a265-50177b6169a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3497570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1593,
        "selector": "L1593-L1622",
        "symbol": "Model._perform_date_checks"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b861c542-fa9d-4c36-b14c-ad3ef92ed83b",
  "subject_name": "django/db/models/base::Model._perform_date_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _perform_date_checks(self, date_checks)"
}
```
