# Fact 4bd8d6af

Store id: 3759af73-220c-4356-89f9-930a31a070d9

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T22:39:48.0401550+00:00`

## Data

```json
{
  "end_line": 196,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 184,
  "symbol": "Lookup.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":184,"selector":"L184-L196","symbol":"Lookup.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 196,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 184,
    "symbol": "Lookup.resolve_expression"
  },
  "id": "3759af73-220c-4356-89f9-930a31a070d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0401550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 184,
        "selector": "L184-L196",
        "symbol": "Lookup.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8ad0213c-ec73-48c1-b594-8f0f838232ae",
  "subject_name": "django/db/models/lookups::Lookup.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
