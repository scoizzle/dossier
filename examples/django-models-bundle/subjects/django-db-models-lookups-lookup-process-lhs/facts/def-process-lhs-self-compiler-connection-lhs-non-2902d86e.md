# Fact 2902d86e

Store id: a084b24b-7d0d-4267-95dd-2ae380921b9c

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
- posted_at: `2026-11-09T22:39:48.0132290+00:00`

## Data

```json
{
  "end_line": 115,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 107,
  "symbol": "Lookup.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L115","symbol":"Lookup.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 115,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 107,
    "symbol": "Lookup.process_lhs"
  },
  "id": "a084b24b-7d0d-4267-95dd-2ae380921b9c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0132290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L115",
        "symbol": "Lookup.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "14e12d2c-241f-42c5-a020-8ec469be7d00",
  "subject_name": "django/db/models/lookups::Lookup.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection, lhs=None)"
}
```
