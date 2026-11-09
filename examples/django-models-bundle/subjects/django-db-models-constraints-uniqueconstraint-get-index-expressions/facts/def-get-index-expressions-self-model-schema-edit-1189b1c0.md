# Fact 1189b1c0

Store id: 63c0647e-2ecb-4509-a69c-0d107778719f

## Text

```text
def _get_index_expressions(self, model, schema_editor)
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
- posted_at: `2026-11-09T22:39:40.7265010+00:00`

## Data

```json
{
  "end_line": 461,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 451,
  "symbol": "UniqueConstraint._get_index_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":451,"selector":"L451-L461","symbol":"UniqueConstraint._get_index_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint._get_index_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 461,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 451,
    "symbol": "UniqueConstraint._get_index_expressions"
  },
  "id": "63c0647e-2ecb-4509-a69c-0d107778719f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7265010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 451,
        "selector": "L451-L461",
        "symbol": "UniqueConstraint._get_index_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "8d57edc4-33c1-4944-9a15-1a4e7e838514",
  "subject_name": "django/db/models/constraints::UniqueConstraint._get_index_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_index_expressions(self, model, schema_editor)"
}
```
