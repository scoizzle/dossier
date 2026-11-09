# Fact df6ad907

Store id: 79f92baa-70d5-4014-9977-2a0731c60c96

## Text

```text
def lazy_related_operation(function, model, *related_models, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.5937050+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "function",
  "parent": "related",
  "start_line": 77,
  "symbol": "lazy_related_operation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"selector":"L77-L95","symbol":"lazy_related_operation"}`

## Items

```json
[
  {
    "text": "Schedule `function` to be called once `model` and all `related_models` have been imported and registered with the app registry. `function` will be called with the newly-loaded model classes as its positional arguments, plus any optional keyword arguments.",
    "locator": {
      "line": 78
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::lazy_related_operation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "function",
    "parent": "related",
    "start_line": 77,
    "symbol": "lazy_related_operation"
  },
  "id": "79f92baa-70d5-4014-9977-2a0731c60c96",
  "items": [
    {
      "locator": {
        "line": 78
      },
      "text": "Schedule `function` to be called once `model` and all `related_models` have been imported and registered with the app registry. `function` will be called with the newly-loaded model classes as its positional arguments, plus any optional keyword arguments."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.5937050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 77,
        "selector": "L77-L95",
        "symbol": "lazy_related_operation"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "52d2c36d-ee25-44b7-861e-005fae0b71e8",
  "subject_name": "django/db/models/fields/related::lazy_related_operation",
  "tags": [
    "entity:function"
  ],
  "text": "def lazy_related_operation(function, model, *related_models, **kwargs)"
}
```
