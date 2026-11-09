# Fact 2cc0d0c7

Store id: 66040ccd-f4dc-49db-9519-3aa108a4902b

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
- posted_at: `2026-11-09T23:44:48.5227630+00:00`

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
  "id": "66040ccd-f4dc-49db-9519-3aa108a4902b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5227630+00:00"
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
  "subject_id": "0bae989e-244a-4fe2-a3f2-b8f8e8846607",
  "subject_name": "django/db/models/base::ModelStateFieldsCacheDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
