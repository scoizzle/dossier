# Fact d2599268

Store id: 3e423485-0fd6-44e2-8dd3-9ba1bf70fa9e

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:48.5272300+00:00`

## Data

```json
{
  "end_line": 646,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 638,
  "symbol": "Model.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":638,"selector":"L638-L646","symbol":"Model.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 646,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 638,
    "symbol": "Model.__eq__"
  },
  "id": "3e423485-0fd6-44e2-8dd3-9ba1bf70fa9e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5272300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 638,
        "selector": "L638-L646",
        "symbol": "Model.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "52eaf21d-2c02-4796-9ef4-ac7aab77c990",
  "subject_name": "django/db/models/base::Model.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
