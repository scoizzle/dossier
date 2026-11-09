# Fact 69114795

Store id: 4084b2e9-f483-4425-9303-65c0dfb67929

## Text

```text
def _check_field_name(self)
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
- posted_at: `2026-11-09T23:44:49.9704230+00:00`

## Data

```json
{
  "end_line": 344,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 312,
  "symbol": "Field._check_field_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":312,"selector":"L312-L344","symbol":"Field._check_field_name"}`

## Items

```json
[
  {
    "text": "Check if field name is valid, i.e. 1) does not end with an underscore, 2) does not contain \"__\" and 3) is not \"pk\".",
    "locator": {
      "line": 313
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_field_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 344,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 312,
    "symbol": "Field._check_field_name"
  },
  "id": "4084b2e9-f483-4425-9303-65c0dfb67929",
  "items": [
    {
      "locator": {
        "line": 313
      },
      "text": "Check if field name is valid, i.e. 1) does not end with an underscore, 2) does not contain \"__\" and 3) is not \"pk\"."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9704230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 312,
        "selector": "L312-L344",
        "symbol": "Field._check_field_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "888fe1e8-f136-4c3a-ae84-478bfa349f21",
  "subject_name": "django/db/models/fields/__init__::Field._check_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_field_name(self)"
}
```
