# Fact 2cc0d0c7

Store id: dccdeefa-ec36-4480-a158-8331ea4f701c

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T22:39:40.3285810+00:00`

## Data

```json
{
  "end_line": 467,
  "entity_kind": "method",
  "parent": "ModelStateFieldsCacheDescriptor",
  "start_line": 463,
  "symbol": "ModelStateFieldsCacheDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":463,"selector":"L463-L467","symbol":"ModelStateFieldsCacheDescriptor.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelStateFieldsCacheDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 467,
    "entity_kind": "method",
    "parent": "ModelStateFieldsCacheDescriptor",
    "start_line": 463,
    "symbol": "ModelStateFieldsCacheDescriptor.__get__"
  },
  "id": "dccdeefa-ec36-4480-a158-8331ea4f701c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3285810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 463,
        "selector": "L463-L467",
        "symbol": "ModelStateFieldsCacheDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "654959a9-d74f-47a3-8748-dfe211c8baf4",
  "subject_name": "django/db/models/base::ModelStateFieldsCacheDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
