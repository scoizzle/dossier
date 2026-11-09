# Fact b5da134e

Store id: fa0677e0-316e-4a8b-80a5-d5eb091bba24

## Text

```text
def _check_unique(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.3799040+00:00`

## Data

```json
{
  "end_line": 1186,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1170,
  "symbol": "ForeignKey._check_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1170,"selector":"L1170-L1186","symbol":"ForeignKey._check_unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey._check_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1186,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1170,
    "symbol": "ForeignKey._check_unique"
  },
  "id": "fa0677e0-316e-4a8b-80a5-d5eb091bba24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3799040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1170,
        "selector": "L1170-L1186",
        "symbol": "ForeignKey._check_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c876e23d-370e-4f75-a7d8-cc7d448f8ed4",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique(self, **kwargs)"
}
```
