# Fact 76e1cf61

Store id: 9019854a-51fe-45d6-a727-3a3bc19fa82b

## Text

```text
def full_clean(self, exclude=None, validate_unique=True, validate_constraints=True)
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
- posted_at: `2026-11-09T23:44:48.5447190+00:00`

## Data

```json
{
  "end_line": 1745,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1700,
  "symbol": "Model.full_clean"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1700,"selector":"L1700-L1745","symbol":"Model.full_clean"}`

## Items

```json
[
  {
    "text": "Call clean_fields(), clean(), validate_unique(), and validate_constraints() on the model. Raise a ValidationError for any errors that occur.",
    "locator": {
      "line": 1701
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.full_clean](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1745,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1700,
    "symbol": "Model.full_clean"
  },
  "id": "9019854a-51fe-45d6-a727-3a3bc19fa82b",
  "items": [
    {
      "locator": {
        "line": 1701
      },
      "text": "Call clean_fields(), clean(), validate_unique(), and validate_constraints() on the model. Raise a ValidationError for any errors that occur."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5447190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1700,
        "selector": "L1700-L1745",
        "symbol": "Model.full_clean"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "0635b716-04f1-405a-99aa-6ac5a19ae6f5",
  "subject_name": "django/db/models/base::Model.full_clean",
  "tags": [
    "entity:method"
  ],
  "text": "def full_clean(self, exclude=None, validate_unique=True, validate_constraints=True)"
}
```
