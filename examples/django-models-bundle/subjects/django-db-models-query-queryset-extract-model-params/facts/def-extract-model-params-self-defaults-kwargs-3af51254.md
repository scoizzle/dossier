# Fact 3af51254

Store id: 38de096f-397e-4093-b84b-9500f2fd2045

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
- posted_at: `2026-11-09T23:32:04.4306440+00:00`

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
  "id": "38de096f-397e-4093-b84b-9500f2fd2045",
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
    "posted_at": "2026-11-09T23:32:04.4306440+00:00"
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
  "subject_id": "11df9cc0-989b-492c-be37-a0c5d5b96ea3",
  "subject_name": "django/db/models/query::QuerySet._extract_model_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _extract_model_params(self, defaults, **kwargs)"
}
```
