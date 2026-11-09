# Fact c2b33c06

Store id: 9dc80d53-b708-4256-8ba8-ed91d1cdf668

## Text

```text
def slice_expression(self, expression, start, length)
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
- posted_at: `2026-11-09T23:44:50.0510310+00:00`

## Data

```json
{
  "end_line": 1197,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1195,
  "symbol": "Field.slice_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1195,"selector":"L1195-L1197","symbol":"Field.slice_expression"}`

## Items

```json
[
  {
    "text": "Return a slice of this field.",
    "locator": {
      "line": 1196
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.slice_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1197,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1195,
    "symbol": "Field.slice_expression"
  },
  "id": "9dc80d53-b708-4256-8ba8-ed91d1cdf668",
  "items": [
    {
      "locator": {
        "line": 1196
      },
      "text": "Return a slice of this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0510310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1195,
        "selector": "L1195-L1197",
        "symbol": "Field.slice_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c1e159fb-4d1d-4479-a0ae-a8c516b664bd",
  "subject_name": "django/db/models/fields/__init__::Field.slice_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def slice_expression(self, expression, start, length)"
}
```
