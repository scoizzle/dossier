# Fact 556935f9

Store id: 38d060dd-509c-4b61-8dff-2397e4170d8c

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
- posted_at: `2026-11-09T22:39:48.1717600+00:00`

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
  "id": "38d060dd-509c-4b61-8dff-2397e4170d8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1717600+00:00"
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
  "subject_id": "66a85e7f-3d15-4b81-a63d-ed02a4bfc281",
  "subject_name": "django/db/models/lookups::PatternLookup.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```
