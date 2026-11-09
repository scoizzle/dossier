# Fact a44b8a69

Store id: a96d79bc-6120-4451-aa05-c0c5d2cb03f2

## Text

```text
def clean_fields(self, exclude=None)
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
- posted_at: `2026-11-09T23:31:53.7594180+00:00`

## Data

```json
{
  "end_line": 1773,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1747,
  "symbol": "Model.clean_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1747,"selector":"L1747-L1773","symbol":"Model.clean_fields"}`

## Items

```json
[
  {
    "text": "Clean all fields and raise a ValidationError containing a dict of all validation errors if any occur.",
    "locator": {
      "line": 1748
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.clean_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1773,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1747,
    "symbol": "Model.clean_fields"
  },
  "id": "a96d79bc-6120-4451-aa05-c0c5d2cb03f2",
  "items": [
    {
      "locator": {
        "line": 1748
      },
      "text": "Clean all fields and raise a ValidationError containing a dict of all validation errors if any occur."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7594180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1747,
        "selector": "L1747-L1773",
        "symbol": "Model.clean_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f97664b8-5749-4055-b5fd-fd9eaee7ac78",
  "subject_name": "django/db/models/base::Model.clean_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def clean_fields(self, exclude=None)"
}
```
