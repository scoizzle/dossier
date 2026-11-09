# Fact 2e777911

Store id: 8b8b8b0e-cfa8-4b85-9552-3f81b668a540

## Text

```text
class IntegerFieldFloatRounding
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.1302240+00:00`

## Data

```json
{
  "end_line": 472,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 463,
  "symbol": "IntegerFieldFloatRounding"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":463,"selector":"L463-L472","symbol":"IntegerFieldFloatRounding"}`

## Items

```json
[
  {
    "text": "Allow floats to work as query values for IntegerField. Without this, the decimal portion of the float would always be discarded.",
    "locator": {
      "line": 464
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldFloatRounding](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 472,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 463,
    "symbol": "IntegerFieldFloatRounding"
  },
  "id": "8b8b8b0e-cfa8-4b85-9552-3f81b668a540",
  "items": [
    {
      "locator": {
        "line": 464
      },
      "text": "Allow floats to work as query values for IntegerField. Without this, the decimal portion of the float would always be discarded."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1302240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 463,
        "selector": "L463-L472",
        "symbol": "IntegerFieldFloatRounding"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b1ead53e-b1a7-4def-a684-0e8d58ad1353",
  "subject_name": "django/db/models/lookups::IntegerFieldFloatRounding",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerFieldFloatRounding"
}
```
