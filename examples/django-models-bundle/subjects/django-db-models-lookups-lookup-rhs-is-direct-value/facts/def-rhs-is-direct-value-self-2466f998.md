# Fact 2466f998

Store id: 4ee5cee6-c1cb-4e9d-bf5a-490d42f4ae28

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
- posted_at: `2026-11-09T23:32:03.1653690+00:00`

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
  "id": "4ee5cee6-c1cb-4e9d-bf5a-490d42f4ae28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1653690+00:00"
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
  "subject_id": "d45398e1-feb5-4803-bf8d-aa6101e9ffa7",
  "subject_name": "django/db/models/lookups::Lookup.rhs_is_direct_value",
  "tags": [
    "entity:method"
  ],
  "text": "def rhs_is_direct_value(self)"
}
```
