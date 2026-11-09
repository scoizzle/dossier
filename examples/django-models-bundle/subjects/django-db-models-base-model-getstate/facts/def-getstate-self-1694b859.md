# Fact 1694b859

Store id: 5685e19e-f801-4334-bdf2-b79258575656

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
- posted_at: `2026-11-09T22:39:40.3341410+00:00`

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
  "id": "5685e19e-f801-4334-bdf2-b79258575656",
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
    "posted_at": "2026-11-09T22:39:40.3341410+00:00"
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
  "subject_id": "3d507029-329d-4aff-8ec8-c18893dd900e",
  "subject_name": "django/db/models/base::Model.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
