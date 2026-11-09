# Fact cfc46260

Store id: 6b4cf42f-1f5f-423a-a211-e56d645361f0

## Text

```text
def get_limit_choices_to(self)
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
- posted_at: `2026-11-09T23:31:58.6385260+00:00`

## Data

```json
{
  "end_line": 490,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 481,
  "symbol": "RelatedField.get_limit_choices_to"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":481,"selector":"L481-L490","symbol":"RelatedField.get_limit_choices_to"}`

## Items

```json
[
  {
    "text": "Return ``limit_choices_to`` for this model field.",
    "locator": {
      "line": 482
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.get_limit_choices_to](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 490,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 481,
    "symbol": "RelatedField.get_limit_choices_to"
  },
  "id": "6b4cf42f-1f5f-423a-a211-e56d645361f0",
  "items": [
    {
      "locator": {
        "line": 482
      },
      "text": "Return ``limit_choices_to`` for this model field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6385260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 481,
        "selector": "L481-L490",
        "symbol": "RelatedField.get_limit_choices_to"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "87009584-c7ce-427f-9491-ffbb1537171d",
  "subject_name": "django/db/models/fields/related::RelatedField.get_limit_choices_to",
  "tags": [
    "entity:method"
  ],
  "text": "def get_limit_choices_to(self)"
}
```
