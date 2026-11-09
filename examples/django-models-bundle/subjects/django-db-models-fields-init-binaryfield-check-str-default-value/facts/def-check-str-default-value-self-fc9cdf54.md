# Fact fc9cdf54

Store id: 5e2d306f-6115-4ec7-8c73-e5ff722e9a73

## Text

```text
def _check_str_default_value(self)
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
- posted_at: `2026-11-09T22:39:42.6921530+00:00`

## Data

```json
{
  "end_line": 2770,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2760,
  "symbol": "BinaryField._check_str_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2760,"selector":"L2760-L2770","symbol":"BinaryField._check_str_default_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField._check_str_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2770,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2760,
    "symbol": "BinaryField._check_str_default_value"
  },
  "id": "5e2d306f-6115-4ec7-8c73-e5ff722e9a73",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6921530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2760,
        "selector": "L2760-L2770",
        "symbol": "BinaryField._check_str_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9ad1677a-ae58-48dd-8630-9dc6a9ebe676",
  "subject_name": "django/db/models/fields/__init__::BinaryField._check_str_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_str_default_value(self)"
}
```
