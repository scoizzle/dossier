# Fact e60ad83d

Store id: b54b40ea-2a3c-4d9e-8059-d657ebbac0e9

## Text

```text
def is_summary(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.9495040+00:00`

## Data

```json
{
  "end_line": 268,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 266,
  "symbol": "WhereNode.is_summary"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L268","symbol":"WhereNode.is_summary"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.is_summary](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 268,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 266,
    "symbol": "WhereNode.is_summary"
  },
  "id": "b54b40ea-2a3c-4d9e-8059-d657ebbac0e9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9495040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L268",
        "symbol": "WhereNode.is_summary"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "8ac637ef-8d8a-43dd-9e16-a8687cde64ce",
  "subject_name": "django/db/models/sql/where::WhereNode.is_summary",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_summary(self)"
}
```
