# Fact 186df9b8

Store id: f64e678a-ba5e-45cf-abe0-fde1dc597a0c

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
- posted_at: `2026-11-09T22:39:49.7392090+00:00`

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
  "id": "f64e678a-ba5e-45cf-abe0-fde1dc597a0c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7392090+00:00"
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
  "subject_id": "91fe53b4-b172-4ffb-8f4f-76999cd8977a",
  "subject_name": "django/db/models/query::QuerySet._validate_values_are_expressions",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _validate_values_are_expressions(values, method_name)"
}
```
