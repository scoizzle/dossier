# Fact df8ab161

Store id: c0b4343b-c941-4d4e-8c68-110fdfe53ec0

## Text

```text
def get_rhs_op(self, connection, rhs)
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
- posted_at: `2026-11-09T23:32:03.3451200+00:00`

## Data

```json
{
  "end_line": 601,
  "entity_kind": "method",
  "parent": "PatternLookup",
  "start_line": 588,
  "symbol": "PatternLookup.get_rhs_op"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":588,"selector":"L588-L601","symbol":"PatternLookup.get_rhs_op"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::PatternLookup.get_rhs_op](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 601,
    "entity_kind": "method",
    "parent": "PatternLookup",
    "start_line": 588,
    "symbol": "PatternLookup.get_rhs_op"
  },
  "id": "c0b4343b-c941-4d4e-8c68-110fdfe53ec0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3451200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 588,
        "selector": "L588-L601",
        "symbol": "PatternLookup.get_rhs_op"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "865c0582-84c7-45ed-bba5-e246b56e4ac1",
  "subject_name": "django/db/models/lookups::PatternLookup.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
