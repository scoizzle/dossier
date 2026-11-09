# Fact da7dceed

Store id: 78e6de31-ce59-4383-8745-4b6c1a01dfae

## Text

```text
def __rmul__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2545090+00:00`

## Data

```json
{
  "end_line": 140,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 139,
  "symbol": "Combinable.__rmul__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":139,"selector":"L139-L140","symbol":"Combinable.__rmul__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rmul__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 140,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 139,
    "symbol": "Combinable.__rmul__"
  },
  "id": "78e6de31-ce59-4383-8745-4b6c1a01dfae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2545090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 139,
        "selector": "L139-L140",
        "symbol": "Combinable.__rmul__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "34f50c33-2df9-4554-8bc9-0ee6c0809e5c",
  "subject_name": "django/db/models/expressions::Combinable.__rmul__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rmul__(self, other)"
}
```
