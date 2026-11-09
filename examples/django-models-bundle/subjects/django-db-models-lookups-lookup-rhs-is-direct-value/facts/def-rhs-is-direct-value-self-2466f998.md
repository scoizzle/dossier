# Fact 2466f998

Store id: 72ba63e9-38ae-4ecc-a2f8-e14517dc44d2

## Text

```text
def rhs_is_direct_value(self)
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
- posted_at: `2026-11-09T22:39:48.0184890+00:00`

## Data

```json
{
  "end_line": 142,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 141,
  "symbol": "Lookup.rhs_is_direct_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L142","symbol":"Lookup.rhs_is_direct_value"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.rhs_is_direct_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 142,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 141,
    "symbol": "Lookup.rhs_is_direct_value"
  },
  "id": "72ba63e9-38ae-4ecc-a2f8-e14517dc44d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0184890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L142",
        "symbol": "Lookup.rhs_is_direct_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "80af1fa1-8955-4713-beb8-f2dc077bde0b",
  "subject_name": "django/db/models/lookups::Lookup.rhs_is_direct_value",
  "tags": [
    "entity:method"
  ],
  "text": "def rhs_is_direct_value(self)"
}
```
