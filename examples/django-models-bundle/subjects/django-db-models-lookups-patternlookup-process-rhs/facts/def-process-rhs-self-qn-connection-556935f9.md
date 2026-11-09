# Fact 556935f9

Store id: 9aaf85ca-c95e-4be5-b30a-058e02fcea28

## Text

```text
def process_rhs(self, qn, connection)
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
- posted_at: `2026-11-09T23:32:03.3484570+00:00`

## Data

```json
{
  "end_line": 616,
  "entity_kind": "method",
  "parent": "PatternLookup",
  "start_line": 603,
  "symbol": "PatternLookup.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":603,"selector":"L603-L616","symbol":"PatternLookup.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::PatternLookup.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 616,
    "entity_kind": "method",
    "parent": "PatternLookup",
    "start_line": 603,
    "symbol": "PatternLookup.process_rhs"
  },
  "id": "9aaf85ca-c95e-4be5-b30a-058e02fcea28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3484570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 603,
        "selector": "L603-L616",
        "symbol": "PatternLookup.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4cc86d9d-760c-404b-9e88-e2a9a534e805",
  "subject_name": "django/db/models/lookups::PatternLookup.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```
