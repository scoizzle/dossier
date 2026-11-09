# Fact 5b550aad

Store id: 1f1fd97d-94df-4609-a078-c3779f147842

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
- posted_at: `2026-11-09T22:39:48.4752620+00:00`

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
  "id": "1f1fd97d-94df-4609-a078-c3779f147842",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4752620+00:00"
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
  "subject_id": "e84e45e7-0290-4738-a61e-c51c88caadc1",
  "subject_name": "django/db/models/manager::BaseManager.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
