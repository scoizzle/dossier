# Fact 186df9b8

Store id: 3241e051-cf9d-42b3-a72b-638ca9a34d1c

## Text

```text
def _validate_values_are_expressions(values, method_name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.6725350+00:00`

## Data

```json
{
  "end_line": 2358,
  "entity_kind": "static_method",
  "parent": "QuerySet",
  "start_line": 2346,
  "symbol": "QuerySet._validate_values_are_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2346,"selector":"L2346-L2358","symbol":"QuerySet._validate_values_are_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._validate_values_are_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2358,
    "entity_kind": "static_method",
    "parent": "QuerySet",
    "start_line": 2346,
    "symbol": "QuerySet._validate_values_are_expressions"
  },
  "id": "3241e051-cf9d-42b3-a72b-638ca9a34d1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6725350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2346,
        "selector": "L2346-L2358",
        "symbol": "QuerySet._validate_values_are_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e1f42a2e-98fc-4a11-96df-0cdfba59c9f7",
  "subject_name": "django/db/models/query::QuerySet._validate_values_are_expressions",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _validate_values_are_expressions(values, method_name)"
}
```
