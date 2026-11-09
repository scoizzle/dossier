# Fact a0c93b95

Store id: c4e66cfd-d0a5-4ab7-bba6-02595ddd48c9

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.8806990+00:00`

## Data

```json
{
  "end_line": 2151,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2104,
  "symbol": "ManyToManyField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2104,"selector":"L2104-L2151","symbol":"ManyToManyField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2151,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2104,
    "symbol": "ManyToManyField.contribute_to_class"
  },
  "id": "c4e66cfd-d0a5-4ab7-bba6-02595ddd48c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8806990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2104,
        "selector": "L2104-L2151",
        "symbol": "ManyToManyField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c93e1c3c-a358-41f3-8554-dd5b2a7b1ff2",
  "subject_name": "django/db/models/fields/related::ManyToManyField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
