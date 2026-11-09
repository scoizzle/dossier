# Fact d2599268

Store id: da443927-f656-4c4a-b174-e61e97d84267

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
- posted_at: `2026-11-09T23:31:53.7336490+00:00`

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
  "id": "da443927-f656-4c4a-b174-e61e97d84267",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7336490+00:00"
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
  "subject_id": "5441d95e-dbcd-41d7-978a-f41dc49e6bb6",
  "subject_name": "django/db/models/base::Model.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
