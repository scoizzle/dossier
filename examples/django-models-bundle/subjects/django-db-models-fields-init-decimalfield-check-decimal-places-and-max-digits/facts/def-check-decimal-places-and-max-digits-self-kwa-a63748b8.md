# Fact a63748b8

Store id: 4f57b25a-c9a0-4ee5-92b8-4a2112d90c2f

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
- posted_at: `2026-11-09T22:39:42.4515680+00:00`

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
  "id": "4f57b25a-c9a0-4ee5-92b8-4a2112d90c2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4515680+00:00"
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
  "subject_id": "d2d47737-3931-4f85-bb6d-7d208691ab6a",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_decimal_places_and_max_digits",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_decimal_places_and_max_digits(self, **kwargs)"
}
```
