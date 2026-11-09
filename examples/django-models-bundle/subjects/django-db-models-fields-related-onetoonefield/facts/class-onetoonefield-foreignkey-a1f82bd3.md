# Fact a1f82bd3

Store id: 601a8ade-dd0a-4e8e-98cc-5116d910eca4

## Text

```text
class OneToOneField(ForeignKey)
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
- posted_at: `2026-11-09T23:31:58.8001800+00:00`

## Data

```json
{
  "end_line": 1398,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 1351,
  "symbol": "OneToOneField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"selector":"L1351-L1398","symbol":"OneToOneField"}`

## Items

```json
[
  {
    "text": "A OneToOneField is essentially the same as a ForeignKey, with the exception that it always carries a \"unique\" constraint with it and the reverse relation always returns the object pointed to (since there will only ever be one), rather than returning a list.",
    "locator": {
      "line": 1352
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1398,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 1351,
    "symbol": "OneToOneField"
  },
  "id": "601a8ade-dd0a-4e8e-98cc-5116d910eca4",
  "items": [
    {
      "locator": {
        "line": 1352
      },
      "text": "A OneToOneField is essentially the same as a ForeignKey, with the exception that it always carries a \"unique\" constraint with it and the reverse relation always returns the object pointed to (since there will only ever be one), rather than returning a list."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8001800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1351,
        "selector": "L1351-L1398",
        "symbol": "OneToOneField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "4c1565a5-e2f3-4fc2-b4f0-ffaa30e720a4",
  "subject_name": "django/db/models/fields/related::OneToOneField",
  "tags": [
    "entity:class"
  ],
  "text": "class OneToOneField(ForeignKey)"
}
```
