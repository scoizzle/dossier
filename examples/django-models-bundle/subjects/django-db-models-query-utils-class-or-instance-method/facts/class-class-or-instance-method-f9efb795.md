# Fact f9efb795

Store id: fa66c36b-6da9-4d6f-b886-21571c363d83

## Text

```text
class class_or_instance_method
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.6384220+00:00`

## Data

```json
{
  "end_line": 333,
  "entity_kind": "class",
  "parent": "query_utils",
  "start_line": 320,
  "symbol": "class_or_instance_method"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"selector":"L320-L333","symbol":"class_or_instance_method"}`

## Items

```json
[
  {
    "text": "Hook used in RegisterLookupMixin to return partial functions depending on the caller type (instance or class of models.Field).",
    "locator": {
      "line": 321
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::class_or_instance_method](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 333,
    "entity_kind": "class",
    "parent": "query_utils",
    "start_line": 320,
    "symbol": "class_or_instance_method"
  },
  "id": "fa66c36b-6da9-4d6f-b886-21571c363d83",
  "items": [
    {
      "locator": {
        "line": 321
      },
      "text": "Hook used in RegisterLookupMixin to return partial functions depending on the caller type (instance or class of models.Field)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6384220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 320,
        "selector": "L320-L333",
        "symbol": "class_or_instance_method"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "8089e49a-52bb-4795-af12-df360a422e77",
  "subject_name": "django/db/models/query_utils::class_or_instance_method",
  "tags": [
    "entity:class"
  ],
  "text": "class class_or_instance_method"
}
```
