# Fact 5c441511

Store id: 3b628777-328b-4ff4-8340-38d3c905a205

## Text

```text
def process_lhs(self, compiler, connection, lhs=None)
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
- posted_at: `2026-11-09T22:39:48.0639320+00:00`

## Data

```json
{
  "end_line": 241,
  "entity_kind": "method",
  "parent": "BuiltinLookup",
  "start_line": 235,
  "symbol": "BuiltinLookup.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":235,"selector":"L235-L241","symbol":"BuiltinLookup.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 241,
    "entity_kind": "method",
    "parent": "BuiltinLookup",
    "start_line": 235,
    "symbol": "BuiltinLookup.process_lhs"
  },
  "id": "3b628777-328b-4ff4-8340-38d3c905a205",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0639320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 235,
        "selector": "L235-L241",
        "symbol": "BuiltinLookup.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "802d8117-83bb-4fd3-8da8-e4cc80602a29",
  "subject_name": "django/db/models/lookups::BuiltinLookup.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection, lhs=None)"
}
```
