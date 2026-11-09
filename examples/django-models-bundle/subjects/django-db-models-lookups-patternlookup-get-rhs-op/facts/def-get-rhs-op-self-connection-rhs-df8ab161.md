# Fact df8ab161

Store id: b84d772f-c66a-423e-81d8-630865a8afef

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
- posted_at: `2026-11-09T23:44:55.0151230+00:00`

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
  "id": "b84d772f-c66a-423e-81d8-630865a8afef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0151230+00:00"
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
  "subject_id": "4fbbeeba-53c7-4a42-9e0a-c2547679ce09",
  "subject_name": "django/db/models/lookups::PatternLookup.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
