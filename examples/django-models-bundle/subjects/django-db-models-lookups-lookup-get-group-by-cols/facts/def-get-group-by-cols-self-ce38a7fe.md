# Fact ce38a7fe

Store id: 09346bea-e53f-4626-9c73-dac0890e0a54

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:32:03.1682740+00:00`

## Data

```json
{
  "end_line": 148,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 144,
  "symbol": "Lookup.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":144,"selector":"L144-L148","symbol":"Lookup.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 148,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 144,
    "symbol": "Lookup.get_group_by_cols"
  },
  "id": "09346bea-e53f-4626-9c73-dac0890e0a54",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1682740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 144,
        "selector": "L144-L148",
        "symbol": "Lookup.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8b9aa95e-21d2-40c6-b364-f2020c9c9cff",
  "subject_name": "django/db/models/lookups::Lookup.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
