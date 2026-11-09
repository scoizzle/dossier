# Fact d2599268

Store id: 7e444b9d-8012-400f-9916-35322b740ecb

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
- posted_at: `2026-11-09T22:39:40.3330900+00:00`

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
  "id": "7e444b9d-8012-400f-9916-35322b740ecb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3330900+00:00"
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
  "subject_id": "d220983b-7fc9-4214-b6ae-f3a9039a137f",
  "subject_name": "django/db/models/base::Model.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
