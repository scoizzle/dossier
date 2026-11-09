# Fact fa2285cf

Store id: 60078825-3d12-48c2-b689-9b143a4070b4

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
- posted_at: `2026-11-09T22:39:48.1542680+00:00`

## Data

```json
{
  "end_line": 546,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 522,
  "symbol": "In.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":522,"selector":"L522-L546","symbol":"In.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 546,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 522,
    "symbol": "In.process_rhs"
  },
  "id": "60078825-3d12-48c2-b689-9b143a4070b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1542680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 522,
        "selector": "L522-L546",
        "symbol": "In.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1a72b6f7-3a69-4af0-91fb-71bb70a414e8",
  "subject_name": "django/db/models/lookups::In.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
