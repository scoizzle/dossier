# Fact 1d5915b0

Store id: d89cc145-b35d-4472-8772-48296346499c

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T23:31:56.4520310+00:00`

## Data

```json
{
  "end_line": 712,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 706,
  "symbol": "Field.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":706,"selector":"L706-L712","symbol":"Field.clone"}`

## Items

```json
[
  {
    "text": "Uses deconstruct() to clone a new copy of this Field. Will not preserve any class attachments/attribute names.",
    "locator": {
      "line": 707
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 712,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 706,
    "symbol": "Field.clone"
  },
  "id": "d89cc145-b35d-4472-8772-48296346499c",
  "items": [
    {
      "locator": {
        "line": 707
      },
      "text": "Uses deconstruct() to clone a new copy of this Field. Will not preserve any class attachments/attribute names."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4520310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 706,
        "selector": "L706-L712",
        "symbol": "Field.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5b593f65-d3b9-4dbf-897d-41ca940cc45e",
  "subject_name": "django/db/models/fields/__init__::Field.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
