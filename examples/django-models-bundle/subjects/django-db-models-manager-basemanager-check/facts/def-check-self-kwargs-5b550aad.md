# Fact 5b550aad

Store id: 1a15db5a-34c2-49a4-9eb6-0c59e88a3270

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:32:03.6643010+00:00`

## Data

```json
{
  "end_line": 80,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 79,
  "symbol": "BaseManager.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":79,"selector":"L79-L80","symbol":"BaseManager.check"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 80,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 79,
    "symbol": "BaseManager.check"
  },
  "id": "1a15db5a-34c2-49a4-9eb6-0c59e88a3270",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6643010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 79,
        "selector": "L79-L80",
        "symbol": "BaseManager.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "4880ae47-56ed-45f4-85cb-48dfe8177f00",
  "subject_name": "django/db/models/manager::BaseManager.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
