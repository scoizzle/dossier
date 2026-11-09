# Fact 39ddc7d2

Store id: 731ac7ec-db79-4e67-95ae-807e138f4356

## Text

```text
def app_config(self)
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
- posted_at: `2026-11-09T23:44:55.4655530+00:00`

## Data

```json
{
  "end_line": 183,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 180,
  "symbol": "Options.app_config"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"selector":"L180-L183","symbol":"Options.app_config"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.app_config](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 183,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 180,
    "symbol": "Options.app_config"
  },
  "id": "731ac7ec-db79-4e67-95ae-807e138f4356",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4655530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 180,
        "selector": "L180-L183",
        "symbol": "Options.app_config"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "fe573c2a-e3e6-4614-af49-e735ca312417",
  "subject_name": "django/db/models/options::Options.app_config",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def app_config(self)"
}
```
