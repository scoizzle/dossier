# Fact e868d7f5

Store id: 0fc83024-fb10-45c0-baca-c30fe500ad99

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.5127210+00:00`

## Data

```json
{
  "end_line": 296,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 294,
  "symbol": "ManyToOneRel.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":294,"selector":"L294-L296","symbol":"ManyToOneRel.identity"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 296,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 294,
    "symbol": "ManyToOneRel.identity"
  },
  "id": "0fc83024-fb10-45c0-baca-c30fe500ad99",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.5127210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 294,
        "selector": "L294-L296",
        "symbol": "ManyToOneRel.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "564338fb-7ebe-460a-945c-b4009a0fb557",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
