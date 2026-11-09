# Fact 847dfddb

Store id: 618268b9-9e00-4217-97f1-b3a96b69063b

## Text

```text
def _check_deprecation_details(self)
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
- posted_at: `2026-11-09T23:44:49.9838910+00:00`

## Data

```json
{
  "end_line": 572,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 547,
  "symbol": "Field._check_deprecation_details"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":547,"selector":"L547-L572","symbol":"Field._check_deprecation_details"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_deprecation_details](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 572,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 547,
    "symbol": "Field._check_deprecation_details"
  },
  "id": "618268b9-9e00-4217-97f1-b3a96b69063b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9838910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 547,
        "selector": "L547-L572",
        "symbol": "Field._check_deprecation_details"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "dd0ab628-16f4-49e3-adf3-09fb79de6321",
  "subject_name": "django/db/models/fields/__init__::Field._check_deprecation_details",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_deprecation_details(self)"
}
```
