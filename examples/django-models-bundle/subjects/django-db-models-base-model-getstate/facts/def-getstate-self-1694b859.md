# Fact 1694b859

Store id: fddb1321-1ede-41ed-95cf-5f5128a52867

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:44:48.5286040+00:00`

## Data

```json
{
  "end_line": 674,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 659,
  "symbol": "Model.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":659,"selector":"L659-L674","symbol":"Model.__getstate__"}`

## Items

```json
[
  {
    "text": "Hook to allow choosing the attributes to pickle.",
    "locator": {
      "line": 660
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 674,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 659,
    "symbol": "Model.__getstate__"
  },
  "id": "fddb1321-1ede-41ed-95cf-5f5128a52867",
  "items": [
    {
      "locator": {
        "line": 660
      },
      "text": "Hook to allow choosing the attributes to pickle."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5286040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 659,
        "selector": "L659-L674",
        "symbol": "Model.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "3b8f5517-e895-41fd-af1b-38699a49e682",
  "subject_name": "django/db/models/base::Model.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
