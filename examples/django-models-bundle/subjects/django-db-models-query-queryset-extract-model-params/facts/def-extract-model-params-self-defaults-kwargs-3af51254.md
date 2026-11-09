# Fact 3af51254

Store id: f7bf354e-d7c3-4b00-8b85-e9c3572a1d51

## Text

```text
def _extract_model_params(self, defaults, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.9354270+00:00`

## Data

```json
{
  "end_line": 1177,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1152,
  "symbol": "QuerySet._extract_model_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1152,"selector":"L1152-L1177","symbol":"QuerySet._extract_model_params"}`

## Items

```json
[
  {
    "text": "Prepare `params` for creating a model instance based on the given kwargs; for use by get_or_create().",
    "locator": {
      "line": 1153
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._extract_model_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1177,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1152,
    "symbol": "QuerySet._extract_model_params"
  },
  "id": "f7bf354e-d7c3-4b00-8b85-e9c3572a1d51",
  "items": [
    {
      "locator": {
        "line": 1153
      },
      "text": "Prepare `params` for creating a model instance based on the given kwargs; for use by get_or_create()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9354270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1152,
        "selector": "L1152-L1177",
        "symbol": "QuerySet._extract_model_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "58cdfebe-60aa-40d6-a683-d4d8e07169df",
  "subject_name": "django/db/models/query::QuerySet._extract_model_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _extract_model_params(self, defaults, **kwargs)"
}
```
