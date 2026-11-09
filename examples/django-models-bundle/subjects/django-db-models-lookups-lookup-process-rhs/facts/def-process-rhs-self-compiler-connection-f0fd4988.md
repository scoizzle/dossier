# Fact f0fd4988

Store id: 41a30a84-0d4a-488b-8c8c-cf818ae807be

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:54.8784210+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 117,
  "symbol": "Lookup.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L139","symbol":"Lookup.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 117,
    "symbol": "Lookup.process_rhs"
  },
  "id": "41a30a84-0d4a-488b-8c8c-cf818ae807be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8784210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L139",
        "symbol": "Lookup.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "36de5130-896c-4164-936a-e0d90d58ad31",
  "subject_name": "django/db/models/lookups::Lookup.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
