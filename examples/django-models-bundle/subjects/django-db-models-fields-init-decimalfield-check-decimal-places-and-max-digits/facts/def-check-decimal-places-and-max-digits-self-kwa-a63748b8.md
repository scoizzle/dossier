# Fact a63748b8

Store id: 5a8efef9-c301-4fbb-a52a-9865b6924fd2

## Text

```text
def _check_decimal_places_and_max_digits(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.1158890+00:00`

## Data

```json
{
  "end_line": 1869,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1858,
  "symbol": "DecimalField._check_decimal_places_and_max_digits"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1858,"selector":"L1858-L1869","symbol":"DecimalField._check_decimal_places_and_max_digits"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField._check_decimal_places_and_max_digits](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1869,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1858,
    "symbol": "DecimalField._check_decimal_places_and_max_digits"
  },
  "id": "5a8efef9-c301-4fbb-a52a-9865b6924fd2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1158890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1858,
        "selector": "L1858-L1869",
        "symbol": "DecimalField._check_decimal_places_and_max_digits"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "eb22dcd3-4d45-42a6-a5aa-05d5e7196dbe",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_decimal_places_and_max_digits",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_decimal_places_and_max_digits(self, **kwargs)"
}
```
